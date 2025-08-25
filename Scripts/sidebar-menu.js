// Enhanced Sidebar Menu JS for better external link handling
$(function(){
  // Current URL and hostname
  const currentUrl = window.location.href;
  const currentHost = window.location.host;
  
  // Process each menu item
  $('.sidebar-menu-item').each(function(){
    const $link = $(this).find('a');
    const href = $link.attr('href');
    
    if(!href) return; // Skip if no href
    
    // Check for active state
    // Case 1: Exact match
    if(currentUrl === href) {
      $(this).addClass('active');
    }
    // Case 2: Contains the URL (for subpages)
    else if(currentUrl.indexOf(href) !== -1 && href !== '#' && href !== '/') {
      $(this).addClass('active');
    }
    // Case 3: External link on the same domain
    else if(href.indexOf(currentHost) !== -1) {
      // Check if current URL contains significant parts of the href
      const hrefParts = href.replace(/https?:\/\//i, '').split('/').filter(Boolean);
      const currentUrlParts = currentUrl.replace(/https?:\/\//i, '').split('/').filter(Boolean);
      
      const matchingParts = hrefParts.filter(part => 
        currentUrlParts.includes(part) && part !== currentHost
      );
      
      if(matchingParts.length > 0) {
        $(this).addClass('active');
      }
    }
  });
  
  // Ensure menu is visible
  if($('.sidebar-menu').length) {
    $('.sidebar-menu').css('visibility', 'visible');
  }
});