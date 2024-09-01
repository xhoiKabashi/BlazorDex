window.triggerAttackAnimation = () => {
  const heroImage = document.getElementById("heroImage");
  if (heroImage) {
    heroImage.classList.add("attack-animation");
    // Remove the class after animation completes
    setTimeout(() => {
      heroImage.classList.remove("attack-animation");
    }, 500); // Duration should match the CSS animation duration
  }
};
function toggleFullScreen() {
  var element = document.body; // or specific element

  if (element.requestFullscreen) {
      element.requestFullscreen();
  } else if (element.webkitRequestFullscreen) { // Safari
      element.webkitRequestFullscreen();
  } else if (element.mozRequestFullScreen) { // Firefox
      element.mozRequestFullScreen();
  } else if (element.msRequestFullscreen) { // IE/Edge
      element.msRequestFullscreen();
  } else if (window.navigator.standalone) { // iOS specific
      // iOS specific full-screen handling
      document.documentElement.style.height = '100%';
      document.body.style.height = '100%';
      document.body.style.overflow = 'hidden';
  } else {
      alert('Full-screen mode is not supported on this device.');
  }
}

