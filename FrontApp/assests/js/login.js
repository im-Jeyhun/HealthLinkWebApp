// const toggleForm = (e) => {

//     e.preventDefault();
//     const container = document.querySelector('.container');
//     container.classList.toggle('active');
//   };



  $('.opre').on("click", function(e){

    e.preventDefault();
    // // modal.style.display = "block";
    // const container = document.querySelector('.container');
    // container.classList.toggle('active');

    $("#change-log").toggleClass("active")
  })

  $('.closre').on("click", function(e){

    e.preventDefault();
    // // modal.style.display = "block";
    // const container = document.querySelector('.container');
    // container.classList.toggle('active');

    $("#change-log").toggleClass("active")
  })

  