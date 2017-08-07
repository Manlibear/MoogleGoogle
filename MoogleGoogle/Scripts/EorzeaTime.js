var E_TIME = 20.5714285714;
var global = {
    utcTime: null,
    eorzeaTime: null
};
window.setInterval(updateClock, Math.floor(1000 * 60 / E_TIME));

function updateClock() {
    global.utcTime = new Date().getTime();
    var eo_timestamp = Math.floor(global.utcTime * E_TIME);
    global.eorzeaTime = new Date();
    global.eorzeaTime.setTime(eo_timestamp);
    showTime();
}

function showTime() {
    var d = new Date();
    d.setTime(global.eorzeaTime);
    var eTime = document.getElementById('e-time');
    var hours = d.getUTCHours();
    var ampm = hours > 11 ? "PM" : "AM";
    if (hours > 12)
        hours -= 12;
    hours = padLeft(hours);
    var minutes = d.getUTCMinutes();
    minutes = padLeft(minutes);
    eTime.innerHTML = hours + ":" + minutes + " " + ampm;
}
function padLeft(val) {
    var str = "" + val;
    var pad = "00";
    return pad.substring(0, pad.length - str.length) + str;
}
updateClock();