function timer() {
    let hoursEl = $('#hours');
    let minutesEl = $('#minutes');
    let secondsEl = $('#seconds');
    let startBtn = $('#start-timer');
    let stopBtn = $('#stop-timer');

    let interval = undefined;

    startBtn.click(function () {
        if(!interval){
            interval = setInterval(step, 1000);
        }
    });
    stopBtn.click(function () {
        clearInterval(interval);
        interval = undefined;
    });

    let sec = 0;
    function step() {
        sec++;
        secondsEl.text(formatTime(sec % 60));
        let mins = sec /60;
        minutesEl.text(formatTime(mins % 60));
        let hours = sec/3600;
        hoursEl.text(formatTime(hours));
    }
    function pad(val) {
        if (val <=9){
            val = `0${val}`;
        }
        return val;
    }

    function formatTime(num) {
        return pad(Math.floor(num));
    }

}