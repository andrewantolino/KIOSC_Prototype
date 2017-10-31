// Write your Javascript code.
$(document).ready(function () {
    console.log("ready!");
    
    var active = false;
    var el;

    $('.options > li').click(function () {
        var el = $(this);

        if (active === false) {
            $('.options > li').removeClass('active');
            el.addClass('active');
            active = true;
        } else if (active === true) {
            $('.options > li').removeClass('active');
            var el = $(this);
            el.addClass('active');
            active = false;
        }
    });

    $('.filters > li').click(function () {
        var el = $(this);

        if (active === false) {
            $('.filters > li').removeClass('active');
            el.addClass('active');
            active = true;
        } else if (active === true) {
            $('.filters > li').removeClass('active');
            var el = $(this);
            el.addClass('active');
            active = false;
        }
    })
});
    function updateTextInput(val) {
        document.getElementById('textInput').value = val;
    }
    function updateTextInput2(val) {
        document.getElementById('textInput2').value = val;
    }
    function updateTextInput3(val) {
        document.getElementById('textInput3').value = val;
    }

