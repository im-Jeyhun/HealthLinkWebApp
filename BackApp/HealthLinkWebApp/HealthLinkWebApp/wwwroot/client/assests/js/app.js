$(".user-icon").click(function(e){

    e.preventDefault();
    console.log($(".auth-area"))
    $(".auth-area").toggleClass("active")
})

function AutoClose() {
    $(".mobil-drop-menu").hide();
    $(".auth-area-mobil").hide();
    $(".mobile-menu").hide();
}

AutoClose();


$(".mobil-drop-down").click(function(e){
    var mobilmenu = e.target.parentElement.parentElement.parentElement.nextElementSibling;
    console.log(mobilmenu);
    $(mobilmenu).slideToggle('1000');

})

$(".user-icon").click(function(e){
    $(".auth-area-mobil").slideToggle('1000');

})

$(".hamburger-btn").click(function(e){
    e.preventDefault()
    $(".mobile-menu").show("slide");

})

$(".close-mobile-btn").click(function(e){

    $(".mobile-menu").hide("slide");

})





const trigger = document.querySelectorAll(".modal-trigger");
const modal = document.querySelector("#modal");
const close = document.querySelector(".close");



$(trigger).on("click", function(){

    modal.style.display = "block";
})
// trigger.addEventListener("click", () => {
// });



$(close).on("click", function(){

  // modal.style.display = "block";
  modal.style.display = "none";
})

// close.addEventListener("click", () => {
//   modal.style.display = "none";

// });

window.addEventListener("click", (event) => {
  if (event.target === modal) {
    modal.style.display = "none";
  }
});

$(".cart-plus-minus").append('<div class="dec qtybutton">-</div><div class="inc qtybutton">+</div>');
$(".qtybutton").on("click", function () {
	var $button = $(this);
	var oldValue = $button.parent().find("input").val();
	if ($button.text() == "+") {
		var newVal = parseFloat(oldValue) + 1;
	} else {
		// Don't allow decrementing below zero
		if (oldValue > 0) {
			var newVal = parseFloat(oldValue) - 1;
		} else {
			newVal = 0;
		}
	}
	$button.parent().find("input").val(newVal);
});


$(window).on('scroll', function () {
	var scroll = $(window).scrollTop();
	if (scroll < 245) {
		$("#sticky-header").removeClass("sticky-menu");
		$('.scroll-to-target').removeClass('open');

	} else {
		$("#sticky-header").addClass("sticky-menu");
		$('.scroll-to-target').addClass('open');
	}
});


/*=============================================
	=    		 Scroll Up  	         =
=============================================*/
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



$(window).load(function(){
	$('.alertbox').click(function(e){
		console.log("salam")
	  alert('Dear customer, your order has been recorded. You will be informed about the current status of the order within 3 days');
	  });
	})




	//Content Loaded
window.addEventListener("DOMContentLoaded", (e) => {
	var header = document.querySelector(".header");
	var chatRoom = document.querySelector(".chat-room");
	var typeArea = document.querySelector(".type-area");
	var btnAdd = document.querySelector(".button-add");
	var others = document.querySelector(".others");
	var emojiBox = document.querySelector(".emoji-button .emoji-box");
	var emojiButton = document.querySelector(".others .emoji-button");
	var emojis = document.querySelectorAll(".emoji-box span");
	var inputText = document.querySelector("#inputText");
	var btnSend = document.querySelector(".button-send");
	var messageArea=document.querySelector(".message.message-right");
	//Header onclick event
	header.addEventListener("click", (e) => {
	  if (typeArea.classList.contains("d-none")) {
		header.style.borderRadius = "20px 20px 0 0";
	  } else {
		header.style.borderRadius = "20px";
	  }
	  typeArea.classList.toggle("d-none");
	  chatRoom.classList.toggle("d-none");
	});
	//Button Add onclick event
	btnAdd.addEventListener("click", (e) => {
	  others.classList.toggle("others-show");
	});
	//Emoji onclick event
	emojiButton.addEventListener("click", (e) => {
	  emojiBox.classList.add("emoji-show");
	});
	 //Button Send onclick event
	btnSend.addEventListener("click", (e) => {
	  var mess=inputText.value;
	  var bubble=document.createElement('div');
	  bubble.className+=" bubble bubble-dark";
	  bubble.textContent=mess;
	  messageArea.appendChild(bubble);
	  inputText.value="";
	});
	for (var emoji of emojis) {
	  emoji.addEventListener("click", (e) => {
		e.stopPropagation();
		emojiBox.classList.remove("emoji-show");
		others.classList.remove("others-show");
		inputText.value+=e.target.textContent;
	  });
	}
  });
  