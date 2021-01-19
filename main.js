$(document).ready(function(){

    $("#btn1").click(function(){
        $("#alert1").show();
        $("#alert2").hide();
        $("#alert3").hide();

    });
    $("#btn2").click(function(){
        $("#alert2").show();
        $("#alert1").hide();
        $("#alert3").hide();

    });
    $("#btn3").click(function(){
        $("#alert3").show();
        $("#alert2").hide();
        $("#alert1").hide();

    });

    $("#kvadrat").click(function(){
        $(this).animate({
            right: '200px',
            width: '100px',
            height: '100px',
            opacity: '0.4',
            fontSize: '5px'
        });

    });

    $("tr").mouseover(function(){
        $(this).css("background-color", "yellow");
    });
    $("tr").mouseout(function(){
        $(this).css("background-color", "white");
    });

    
});