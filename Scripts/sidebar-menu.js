// Simplified Sidebar Menu JS: only mark active external link
$(function(){
  const currentHost = location.host;
  $('.sidebar-menu-item').each(function(){
     const href = $(this).find('a').attr('href');
     if(href && href.indexOf(currentHost) !== -1 && location.href.indexOf(href) !== -1){
        $(this).addClass('active');
     }
  });
});