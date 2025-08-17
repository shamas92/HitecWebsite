// Admission Modal JavaScript

// Function to show the modal
function showAdmissionModal() {
    const modal = document.getElementById('admissionModal');
    if (modal) {
        modal.style.display = 'flex';
        document.body.style.overflow = 'hidden'; // Prevent background scrolling
        
        // Add event listener for ESC key
        document.addEventListener('keydown', handleEscKey);
    }
}

// Function to close the modal
function closeAdmissionModal() {
    const modal = document.getElementById('admissionModal');
    if (modal) {
        modal.style.display = 'none';
        document.body.style.overflow = ''; // Restore scrolling
        
        // Remove event listener for ESC key
        document.removeEventListener('keydown', handleEscKey);
        
        // Set session storage to remember modal was closed
        sessionStorage.setItem('admissionModalClosed', 'true');
    }
}

// Handle ESC key press
function handleEscKey(event) {
    if (event.key === 'Escape') {
        closeAdmissionModal();
    }
}

// Close modal when clicking outside the modal container
function handleModalOverlayClick(event) {
    const modalContainer = document.querySelector('.modal-container');
    if (event.target === document.getElementById('admissionModal')) {
        closeAdmissionModal();
    }
}

// Initialize modal functionality
function initializeAdmissionModal() {
    const modal = document.getElementById('admissionModal');
    
    if (modal) {
        // Add click event listener to modal overlay
        modal.addEventListener('click', handleModalOverlayClick);
        
        // Prevent modal container clicks from closing modal
        const modalContainer = modal.querySelector('.modal-container');
        if (modalContainer) {
            modalContainer.addEventListener('click', function(event) {
                event.stopPropagation();
            });
        }
        
        // Check if we're on the home page and modal hasn't been closed in this session
        const isHomePage = window.location.pathname === '/' || window.location.pathname === '/Home' || window.location.pathname === '/Home/Index';
        const modalClosed = sessionStorage.getItem('admissionModalClosed');
        
        if (isHomePage && !modalClosed) {
            // Show modal after page loads with a slight delay
            setTimeout(function() {
                showAdmissionModal();
            }, 1000); // 1 second delay
        }
    }
}

// Initialize when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    initializeAdmissionModal();
});

// Initialize when page is fully loaded (fallback)
window.addEventListener('load', function() {
    if (!document.getElementById('admissionModal')) {
        setTimeout(initializeAdmissionModal, 500);
    }
});