document.addEventListener('DOMContentLoaded', () => {
    
    

    document.getElementsById('time').addEventListener('click', DisplayDate)


    function DisplayDate() {
      document.getElementsByClassName("btn").innerHTML = Date;
    }

})


