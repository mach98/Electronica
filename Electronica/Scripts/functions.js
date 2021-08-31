startX = 0
newX = 0
WhichSwipe = (newX, startX) => {
    if (newX > (startX + 100)) {;
        (body.classList.contains('is-active')) ? ToggleNav(): null
    } else {
        return false
    }
}
handleTouchStart = (e) => {
    startX = e.changedTouches[0].clientX
}

handleTouchMove = (e) => {
    newX = e.changedTouches[0].clientX
}

handleTouchEnd = (e) => {
    WhichSwipe(newX, startX)
}

ToggleNav = () => {
    navToggle.classList.toggle('is-active')
    body.classList.toggle('is-active')
    nav.classList.toggle('is-active');
    (navToggle.innerText == 'menu') ? navToggle.innerText = 'close': navToggle.innerText = 'menu'
}
