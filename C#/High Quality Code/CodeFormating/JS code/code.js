let browser = navigator.appName;
let pX = 0;
let pY = 0;
let addScroll = false;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

document.onmousemove = mouseMove;

if (browser === "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(evn) {
    if (browser === "Netscape") {
        let theLayer = document.getElementById('ToolTip');
        pX = evn.pageX - 5;
        pY = evn.pageY;

        if (theLayer.style.visibility == 'show') {
            PopTip();
        }
    } else {
        pX = event.x - 5;
        pY = event.y;

        if (theLayer.style.visibility == 'visible') {
            PopTip();
        }
    }
}

function popTip(ToolTip) {
    let theLayer = document.getElementById('ToolTip');

    if (browser === "Netscape") {
        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.style.visibility = 'show';
    } else {
        theLayer = document.getElementById('ToolTip');

        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function hideTip() {
    let args = HideTip.arguments;
    let theLayer = document.getElementById('ToolTip');

    if (browser === "Netscape") {
        theLayer.style.visibility = 'hide';
    } else {
        theLayer.style.visibility = 'hidden';
    }
}

function hideMenu(id) {
    let menu = document.getElementById(id);

    if (browser === "Netscape") {
        menu.style.visibility = 'hide';
    } else {
        menu.style.visibility = 'hidden';
    }
}

function showMenu(id) {
    let menu = document.getElementById(id);

    if (browser === "Netscape") {
        menu.visibility = 'show';
    } else {
        menu.style.visibility = 'visible';
    }
}