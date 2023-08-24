$(document).ready(function () {
    console.log('time 2 rock');
    const meow = new Audio('audio/meow.mp3');
    const $mike = $('#mike');
    const $button = $('#consent-button');
    const $chaosMode = $('#chaos-mode');
    const chaosArr = [];
    let mewCounter = 0;
    let mikeHeight = 400;
    let fontSize = 10;
    let mewActivated = false;

    const chaos = () => {
        console.log(`Meow Levels At: ${mewCounter} and rising!`);
        setTimeout(() => {
            $('body').append('<p>MEOW MEOW MEOW MEOW MEOW</p>');
            mikeHeight += 5;
            fontSize += 1;
            $mike.width(mikeHeight);
            $('p').css('font-size', (fontSize + 1).toString() + 'px');
            mewCounter++;
            let audio = '<audio id="' + mewCounter + '" src="audio/meow.mp3"/>';
            $('body').append(audio);
            let mew = document.getElementById(mewCounter);
            mew.play();
            mew.addEventListener('ended', e => {
                mew.play();
            })
            //for (let i = 1; i <= mewCounter; i++) {
            //    let mew = document.getElementById(i);
            //    if (mew.paused) {
            //        mew.play();
            //    }
            //}
            chaos();
        }, 400);
    }
    
    $button.on('click', (e) => {
        console.log('meow activated');
        $('body').prepend('<h2>meow has been activated!!!!!</h2');
        mewActivated = true;
        $button.remove();
    });
$chaosMode.on('click', e => {
    meowActivated = true;
        $button.remove();
        $chaosMode.remove();
        alert('you fucked up, pal.');
        chaos();
    });
$mike.on('mouseenter', (e) => {
    if (mewActivated) {
        if (meow.paused) {
            meow.play();
        } else {
            meow.currentTime = 0;
        }
        $('body').append('<p>MEOW MEOW MEOW MEOW MEOW</p>');
    }
    });
});