// Image Crop Functionality
class ImageCropper {
    constructor(container) {
        this.container = container;
        this.image = null;
        this.cropOverlay = null;
        this.isDragging = false;
        this.isResizing = false;
        this.startX = 0;
        this.startY = 0;
        this.cropData = {
            x: 50,
            y: 50,
            width: 200,
            height: 150
        };
        this.aspectRatio = null;
        this.init();
    }

    init() {
        this.setupFileInput();
        this.setupControls();
    }

    setupFileInput() {
        const fileInput = this.container.querySelector('#facility-image-input');
        const fileLabel = this.container.querySelector('.file-input-label');

        fileInput.addEventListener('change', (e) => {
            const file = e.target.files[0];
            if (file && file.type.startsWith('image/')) {
                this.loadImage(file);
            }
        });

        // Drag and drop functionality
        fileLabel.addEventListener('dragover', (e) => {
            e.preventDefault();
            fileLabel.style.borderColor = '#007bff';
            fileLabel.style.background = '#f0f8ff';
        });

        fileLabel.addEventListener('dragleave', (e) => {
            e.preventDefault();
            fileLabel.style.borderColor = '#ddd';
            fileLabel.style.background = '#f9f9f9';
        });

        fileLabel.addEventListener('drop', (e) => {
            e.preventDefault();
            fileLabel.style.borderColor = '#ddd';
            fileLabel.style.background = '#f9f9f9';
            
            const files = e.dataTransfer.files;
            if (files.length > 0 && files[0].type.startsWith('image/')) {
                fileInput.files = files;
                this.loadImage(files[0]);
            }
        });
    }

    setupControls() {
        // Width and height inputs
        const widthInput = this.container.querySelector('#crop-width');
        const heightInput = this.container.querySelector('#crop-height');
        const aspectRatioSelect = this.container.querySelector('#aspect-ratio');

        widthInput.addEventListener('input', () => {
            this.cropData.width = parseInt(widthInput.value) || 0;
            if (this.aspectRatio) {
                this.cropData.height = Math.round(this.cropData.width / this.aspectRatio);
                heightInput.value = this.cropData.height;
            }
            this.updateCropOverlay();
        });

        heightInput.addEventListener('input', () => {
            this.cropData.height = parseInt(heightInput.value) || 0;
            if (this.aspectRatio) {
                this.cropData.width = Math.round(this.cropData.height * this.aspectRatio);
                widthInput.value = this.cropData.width;
            }
            this.updateCropOverlay();
        });

        // Position inputs
        const posXInput = this.container.querySelector('#crop-pos-x');
        const posYInput = this.container.querySelector('#crop-pos-y');

        posXInput.addEventListener('input', () => {
            this.cropData.x = parseInt(posXInput.value) || 0;
            this.updateCropOverlay();
        });

        posYInput.addEventListener('input', () => {
            this.cropData.y = parseInt(posYInput.value) || 0;
            this.updateCropOverlay();
        });

        // Aspect ratio select
        aspectRatioSelect.addEventListener('change', () => {
            const value = aspectRatioSelect.value;
            if (value === 'freeform') {
                this.aspectRatio = null;
            } else {
                const [w, h] = value.split(':').map(Number);
                this.aspectRatio = w / h;
                this.cropData.height = Math.round(this.cropData.width / this.aspectRatio);
                heightInput.value = this.cropData.height;
                this.updateCropOverlay();
            }
        });

        // Crop button
        const cropBtn = this.container.querySelector('#crop-btn');
        cropBtn.addEventListener('click', () => {
            this.cropImage();
        });

        // Reset button
        const resetBtn = this.container.querySelector('#reset-btn');
        resetBtn.addEventListener('click', () => {
            this.resetCrop();
        });
    }

    loadImage(file) {
        const reader = new FileReader();
        reader.onload = (e) => {
            const img = new Image();
            img.onload = () => {
                this.displayImage(img, e.target.result);
            };
            img.src = e.target.result;
        };
        reader.readAsDataURL(file);
    }

    displayImage(img, src) {
        const cropArea = this.container.querySelector('.crop-area');
        const previewContainer = this.container.querySelector('.crop-preview-container');
        
        // Create image element
        this.image = document.createElement('img');
        this.image.src = src;
        this.image.className = 'crop-image';
        
        // Clear previous content
        previewContainer.innerHTML = '';
        previewContainer.appendChild(this.image);
        
        // Show crop area
        cropArea.style.display = 'block';
        
        // Wait for image to load and get dimensions
        this.image.onload = () => {
            this.imageWidth = this.image.offsetWidth;
            this.imageHeight = this.image.offsetHeight;
            this.naturalWidth = img.naturalWidth;
            this.naturalHeight = img.naturalHeight;
            
            // Initialize crop overlay
            this.createCropOverlay();
            this.updateInputs();
        };
    }

    createCropOverlay() {
        // Remove existing overlay
        if (this.cropOverlay) {
            this.cropOverlay.remove();
        }

        // Create crop overlay
        this.cropOverlay = document.createElement('div');
        this.cropOverlay.className = 'crop-overlay';
        
        // Create resize handles
        const handles = ['nw', 'ne', 'sw', 'se', 'n', 's', 'w', 'e'];
        handles.forEach(handle => {
            const handleEl = document.createElement('div');
            handleEl.className = `crop-handle ${handle}`;
            handleEl.dataset.handle = handle;
            this.cropOverlay.appendChild(handleEl);
        });

        // Add event listeners
        this.setupCropEvents();
        
        // Add to container
        this.container.querySelector('.crop-preview-container').appendChild(this.cropOverlay);
        
        // Position overlay
        this.updateCropOverlay();
    }

    setupCropEvents() {
        // Mouse down on overlay (for dragging)
        this.cropOverlay.addEventListener('mousedown', (e) => {
            if (e.target.classList.contains('crop-handle')) {
                this.startResize(e);
            } else {
                this.startDrag(e);
            }
        });

        // Global mouse events
        document.addEventListener('mousemove', (e) => {
            if (this.isDragging) {
                this.drag(e);
            } else if (this.isResizing) {
                this.resize(e);
            }
        });

        document.addEventListener('mouseup', () => {
            this.stopDrag();
            this.stopResize();
        });
    }

    startDrag(e) {
        e.preventDefault();
        this.isDragging = true;
        this.startX = e.clientX - this.cropData.x;
        this.startY = e.clientY - this.cropData.y;
        this.cropOverlay.style.cursor = 'grabbing';
    }

    drag(e) {
        if (!this.isDragging) return;
        
        const newX = e.clientX - this.startX;
        const newY = e.clientY - this.startY;
        
        // Constrain to image bounds
        this.cropData.x = Math.max(0, Math.min(this.imageWidth - this.cropData.width, newX));
        this.cropData.y = Math.max(0, Math.min(this.imageHeight - this.cropData.height, newY));
        
        this.updateCropOverlay();
        this.updateInputs();
    }

    stopDrag() {
        this.isDragging = false;
        this.cropOverlay.style.cursor = 'move';
    }

    startResize(e) {
        e.preventDefault();
        e.stopPropagation();
        this.isResizing = true;
        this.resizeHandle = e.target.dataset.handle;
        this.startX = e.clientX;
        this.startY = e.clientY;
        this.originalCropData = { ...this.cropData };
    }

    resize(e) {
        if (!this.isResizing) return;
        
        const deltaX = e.clientX - this.startX;
        const deltaY = e.clientY - this.startY;
        const handle = this.resizeHandle;
        const original = this.originalCropData;
        
        let newX = original.x;
        let newY = original.y;
        let newWidth = original.width;
        let newHeight = original.height;
        
        // Handle resizing based on which handle is being dragged
        if (handle.includes('w')) {
            newX = original.x + deltaX;
            newWidth = original.width - deltaX;
        }
        if (handle.includes('e')) {
            newWidth = original.width + deltaX;
        }
        if (handle.includes('n')) {
            newY = original.y + deltaY;
            newHeight = original.height - deltaY;
        }
        if (handle.includes('s')) {
            newHeight = original.height + deltaY;
        }
        
        // Maintain aspect ratio if set
        if (this.aspectRatio) {
            if (handle.includes('w') || handle.includes('e')) {
                newHeight = newWidth / this.aspectRatio;
            } else {
                newWidth = newHeight * this.aspectRatio;
            }
        }
        
        // Constrain to minimum size
        newWidth = Math.max(20, newWidth);
        newHeight = Math.max(20, newHeight);
        
        // Constrain to image bounds
        if (newX < 0) {
            newWidth += newX;
            newX = 0;
        }
        if (newY < 0) {
            newHeight += newY;
            newY = 0;
        }
        if (newX + newWidth > this.imageWidth) {
            newWidth = this.imageWidth - newX;
        }
        if (newY + newHeight > this.imageHeight) {
            newHeight = this.imageHeight - newY;
        }
        
        this.cropData = { x: newX, y: newY, width: newWidth, height: newHeight };
        this.updateCropOverlay();
        this.updateInputs();
    }

    stopResize() {
        this.isResizing = false;
        this.resizeHandle = null;
    }

    updateCropOverlay() {
        if (!this.cropOverlay) return;
        
        this.cropOverlay.style.left = this.cropData.x + 'px';
        this.cropOverlay.style.top = this.cropData.y + 'px';
        this.cropOverlay.style.width = this.cropData.width + 'px';
        this.cropOverlay.style.height = this.cropData.height + 'px';
    }

    updateInputs() {
        // Convert to natural image coordinates
        const scaleX = this.naturalWidth / this.imageWidth;
        const scaleY = this.naturalHeight / this.imageHeight;
        
        const naturalCrop = {
            x: Math.round(this.cropData.x * scaleX),
            y: Math.round(this.cropData.y * scaleY),
            width: Math.round(this.cropData.width * scaleX),
            height: Math.round(this.cropData.height * scaleY)
        };
        
        this.container.querySelector('#crop-width').value = naturalCrop.width;
        this.container.querySelector('#crop-height').value = naturalCrop.height;
        this.container.querySelector('#crop-pos-x').value = naturalCrop.x;
        this.container.querySelector('#crop-pos-y').value = naturalCrop.y;
    }

    cropImage() {
        if (!this.image) return;
        
        // Convert display coordinates to natural image coordinates
        const scaleX = this.naturalWidth / this.imageWidth;
        const scaleY = this.naturalHeight / this.imageHeight;
        
        const cropParams = {
            x: Math.round(this.cropData.x * scaleX),
            y: Math.round(this.cropData.y * scaleY),
            width: Math.round(this.cropData.width * scaleX),
            height: Math.round(this.cropData.height * scaleY)
        };
        
        // Create canvas for cropping
        const canvas = document.createElement('canvas');
        const ctx = canvas.getContext('2d');
        
        canvas.width = cropParams.width;
        canvas.height = cropParams.height;
        
        // Create image object from source
        const img = new Image();
        img.onload = () => {
            ctx.drawImage(
                img,
                cropParams.x, cropParams.y, cropParams.width, cropParams.height,
                0, 0, cropParams.width, cropParams.height
            );
            
            // Convert to blob and show result
            canvas.toBlob((blob) => {
                this.showCroppedResult(blob, canvas.toDataURL());
            }, 'image/jpeg', 0.9);
        };
        img.src = this.image.src;
    }

    showCroppedResult(blob, dataUrl) {
        const resultArea = this.container.querySelector('.cropped-result');
        const preview = this.container.querySelector('.cropped-preview');
        
        preview.src = dataUrl;
        resultArea.style.display = 'block';
        
        // Store blob for upload
        this.croppedBlob = blob;
        
        // Setup upload button
        const uploadBtn = this.container.querySelector('.upload-final-btn');
        uploadBtn.onclick = () => {
            this.uploadImage();
        };
    }

    resetCrop() {
        const cropArea = this.container.querySelector('.crop-area');
        const resultArea = this.container.querySelector('.cropped-result');
        const fileInput = this.container.querySelector('#facility-image-input');
        
        cropArea.style.display = 'none';
        resultArea.style.display = 'none';
        fileInput.value = '';
        
        if (this.cropOverlay) {
            this.cropOverlay.remove();
            this.cropOverlay = null;
        }
        
        this.image = null;
        this.croppedBlob = null;
    }

    uploadImage() {
        if (!this.croppedBlob) {
            alert('No image to upload. Please crop an image first.');
            return;
        }
        
        const formData = new FormData();
        formData.append('croppedImage', this.croppedBlob, 'facility-image.jpg');
        
        // Show loading state
        const uploadBtn = this.container.querySelector('.upload-final-btn');
        const originalText = uploadBtn.textContent;
        uploadBtn.textContent = 'Uploading...';
        uploadBtn.disabled = true;
        
        // Upload to server
        fetch('/Faculties/UploadFacilityImage', {
            method: 'POST',
            body: formData
        })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                alert('Image uploaded successfully!');
                this.resetCrop();
            } else {
                alert('Upload failed: ' + (data.message || 'Unknown error'));
            }
        })
        .catch(error => {
            console.error('Upload error:', error);
            alert('Upload failed. Please try again.');
        })
        .finally(() => {
            uploadBtn.textContent = originalText;
            uploadBtn.disabled = false;
        });
    }
}

// Initialize image cropper when DOM is loaded
document.addEventListener('DOMContentLoaded', function() {
    const cropContainer = document.getElementById('image-crop-container');
    if (cropContainer) {
        new ImageCropper(cropContainer);
    }
});