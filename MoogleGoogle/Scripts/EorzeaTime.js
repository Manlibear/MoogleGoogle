var E_TIME_SPAN = 20.5714285714;
var E_TIME = {
    utcTime: null,
    eorzeaTime: null,
    eorzeaTimeKey: null,
    tickFunction: null,
    convertToRealTime: function (d) { },
    convertToTimeKey: function (t) {
        var totalMinsInDay = 24 * 60;
        var mins = (parseFloat(t.split(":")[0]) * 60) + parseFloat(t.split(":")[1]);
        
        return mins / totalMinsInDay;
    }
};


window.setInterval(updateClock, Math.floor(1000 * 60 / E_TIME_SPAN));

function updateClock() {
    E_TIME.utcTime = new Date().getTime();
    var eo_timestamp = Math.floor(E_TIME.utcTime * E_TIME_SPAN);
    E_TIME.eorzeaTime = new Date();
    E_TIME.eorzeaTime.setTime(eo_timestamp);
    showTime();

    E_TIME.eorzeaTimeKey = E_TIME.convertToTimeKey(E_TIME.eorzeaTimeShort);

    if (E_TIME.tickFunction) {
        E_TIME.tickFunction();
    }
}

function showTime() {
    var d = new Date();
    d.setTime(E_TIME.eorzeaTime);
    var eTime = document.getElementById('e-time');
    var hours = d.getUTCHours();

    hours = padLeft(hours);
    var minutes = d.getUTCMinutes();
    minutes = padLeft(minutes);
    eTime.innerHTML = E_TIME.eorzeaTimeShort = hours + ":" + minutes;
}
function padLeft(val) {
    var str = "" + val;
    var pad = "00";
    return pad.substring(0, pad.length - str.length) + str;
}
updateClock();