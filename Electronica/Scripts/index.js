require('../../src/css/style.scss')

;
(() => {
    "use strict"

    document.addEventListener("DOMContentLoaded", function(e) {
        require('../../src/js/variables.js')
        require('../../src/js/functions.js')

        // Set padding bassed on height of the masthead
        html.style.paddingTop = ~~(mastheadHeight)
        nav.style.paddingTop = ~~(mastheadHeight)
        nav.style.display = 'block'
            // Toggle side nav on select of toggle button
        navToggle.addEventListener("click", () => {
            ToggleNav()
        })

        // Promises
        const getImage = (url) => {
            return new Promise(function(resolve, reject) {
                var img = new Image()
                img.onload = function() {
                    resolve(url)
                }
                img.onerror = function() {
                    reject(url)
                }
                img.src = url
            })
        }

        getImage('http://c767204.r4.cf2.rackcdn.com/3016377b-e8ee-4b21-b2bd-17f8ba8dcffc.jpg').then((url) => {
            // Create all the necessary parts
            let container = document.createElement('div')
            let group = document.createElement('div')
            let hero = document.createElement("div")

            // Name the necessary parts
            container.className = 'container'
            group.className = 'group'
            hero.id = 'hero'

            // Insert a #hero element into the <body> before the <main>
            body.insertBefore(hero, main)
            main.style.marginTop = '80vh'

            // Insert a .group element into the <body> before the <main>
            body.insertBefore(group, main)
                // Fill the .group with the content of #hero and <main>
            group.innerHTML = hero.outerHTML + main.outerHTML

            // Insert a .container element into the <body> before the <group>
            body.insertBefore(container, group)
                // Fill the .container with the contents of .group
            container.innerHTML = group.outerHTML

            // Make the .container parallax
            container.classList.toggle('parallax')

            // Remove the extra .group element and the extra <main> element
            body.removeChild(group)
            body.removeChild(main)
            body.removeChild(hero)

            // Pass the url of the image into the next part of the promise
            return url

        }).then((url) => {
            let hero = document.querySelector('#hero')
            hero.style.backgroundImage = "url('" + url + "')"
            hero.style.height = "80vh"
            let heroTitle = main.querySelector('.inner').getElementsByTagName('h1')[0]
            hero.innerHTML = "<h1>" + heroTitle.innerText + "</h1>"
            //let element = document.getElementsByTagName('h1')
            //element.parentNode.removeChild(element)

        })

        // Touch/swipe event to close navigation
        document.addEventListener('touchstart', handleTouchStart, false)
        document.addEventListener('touchmove', handleTouchMove, false)
        document.addEventListener('touchend', handleTouchEnd, false)

        // END onload
    })

})() // END IIFE
