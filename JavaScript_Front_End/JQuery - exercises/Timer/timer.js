function timer() {
    let hours = $('#hours');
    let minutes = $('#minutes');
    let seconds = $('#seconds');
    let startBtn = $('#start-timer');
    let stopBtn = $('#stop-timer');

    let interval = undefined;

    startBtn.on("click", function () {
        if (!interval) {
            interval = setInterval(step, 1000);
        }
    });

    stopBtn.on("click", function () {
        clearInterval(interval);
        interval = undefined;
    });

    let sec = 0;

    function step() {
        sec++;
        seconds.text(formatTime(sec % 60));
        let mins = sec / 60;
        minutes.text(formatTime(mins % 60));
        let hour = sec / 3600;
        hours.text(formatTime(hour));
    }

    function formatTime(num) {
        return pad(Math.floor(num));
    }

    function pad(val) {
        if (val <= 9) {
            val = `0${val}`;
        }
        return val;
    }
}