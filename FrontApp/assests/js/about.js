if ($('.scroll-to-target').length) {
    $(".scroll-to-target").on('click', function () {
      var target = $(this).attr('data-target');
      // animate
      $('html, body').animate({
        scrollTop: $(target).offset().top
      }, 1000);
  
    });
  }
  
  
  function preloader() {
      $('#preloader').delay(0).fadeOut();
  };
  
  $(window).on('load', function () {
      preloader();
  
  });


  function easyPieChart() {
	$('.fact-item').on('inview', function (event, isInView) {
		if (isInView) {
			$('.chart').easyPieChart({
				scaleLength: 0,
				lineWidth: 10,
				trackWidth: 10,
				size: 143,
				lineCap: 'square',
				rotate: 360,
				animate: 3000,
				trackColor: '#50b1f9',
				barColor: '#edf4fa',
			});
		}
	});
}
easyPieChart();