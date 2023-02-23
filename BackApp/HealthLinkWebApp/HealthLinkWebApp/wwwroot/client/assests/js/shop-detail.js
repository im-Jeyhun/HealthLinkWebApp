$('.shop-menu-nav button, .shop-details-dimension li, .shop-details-color li').on('click', function (event) {
	$(this).siblings('.active').removeClass('active');
	$(this).addClass('active');
	event.preventDefault();
});