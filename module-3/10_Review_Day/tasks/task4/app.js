document.addEventListener('DOMContentLoaded', () => {

    document.getElementById('btn1').addEventListener('click', changeColor)
    document.getElementById('btn1').addEventListener('dblclick', changeColor2)
   
    function changeColor(){
        document.body.style.backgroundColor = "beige";
    }

    function changeColor2(){
        document.body.style.backgroundColor = "cornflowerblue";
    }

})