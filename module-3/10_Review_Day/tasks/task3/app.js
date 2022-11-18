document.addEventListener('DOMContentLoaded', () => {
    DisplayDate();
    

    document.getElementsByClassName('btn').addEventListener('click', DisplayDate())


    function DisplayDate() {
      document.getElementsByClassName("btn").innerHTML = Date();
    }

})


