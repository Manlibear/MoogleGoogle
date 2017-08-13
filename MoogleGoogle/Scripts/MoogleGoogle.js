
function notify(obj) {
    if (Notification.permission !== "granted")
        Notification.requestPermission();
    else {

        if (!obj.Icon) {
            obj.Icon = "/Images/moogle-icon.png";
        }


        var notification = new Notification(obj.Title, {
            icon: obj.Icon,
            body: obj.Body,
        });

        if (obj.OnClick) {

            notification.onclick = obj.OnClick;
        }

    }
}


$(document).load(function () {

    if (!Notification) {
        alert('Desktop notifications not available in your browser, only in Chrome.');
        return;
    }

    if (Notification.permission !== "granted")
        Notification.requestPermission();

});