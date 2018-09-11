//<script type = "text/javascript" >

//    var MovRaton = 0;

//    function CambiaPosicion() {
//    MovRaton = (MovRaton + 1) % 10;
//    if (MovRaton == 0) {
//        <Text>
//            @:Boton.style.top = window.event.y - Math.random() * 30 - Boton.clientHeight - 10;
//            @:Boton.style.left = window.event.x - Math.random() * 30 - Boton.clientWidth - 10;
//            </Text>


//    }
//}

//</script >
var MovRaton=0
    
function CambiaPosicion(){
        MovRaton = (MovRaton + 1) % 10
if (MovRaton==0) {
        Boton.style.top = window.event.y - Math.random() * 30 - Boton.clientHeight - 10
        Boton.style.left=window.event.x - Math.random()*30-Boton.clientWidth-10
  }
}
