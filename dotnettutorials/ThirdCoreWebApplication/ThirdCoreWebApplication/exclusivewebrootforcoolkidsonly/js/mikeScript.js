$(document).ready(function () {
    console.log('time 2 rock');
    const meow = new Audio('audio/meow.mp3');
    const $mike = $('#mike');
    const $button = $('#consent-button');
    const $chaosMode = $('#chaos-mode');

    const chaos = () => {
        setTimeout(() => {
            $mike.attr('width', $mike.attr('width') + 5);
            $mike.attr('height', $mike.attr('height') + 5);
            $('p').attr('font-size', $('p').attr('font-size') + 5);
            $('body').append('<audio autoplay src="audio/meow.mp3"/>');
            $('audio').play();
            chaos();
        }, 1000);
    }
    
    $button.on('click', (e) => {
        console.log('meow activated');
        $('body').prepend('<h2>meow has been activated!!!!!</h2');
        $button.remove();
    });
    $chaosMode.on('click', e => {
        $button.remove();
        $chaosMode.remove();
        alert('you fucked up, pal.');
        chaos();
    });
    $mike.on('mouseenter', (e) => {
        if (meow.paused) {
            meow.play();
        } else {
            meow.currentTime = 0;
        }
        $('body').append('<p>MEOW MEOW MEOW MEOW MEOW</p>');
    });
});