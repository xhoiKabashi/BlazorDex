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
function requestFullScreen() {
  var element = document.documentElement;

  if (element.requestFullscreen) {
      element.requestFullscreen();
  } else if (element.mozRequestFullScreen) { // Firefox
      element.mozRequestFullScreen();
  } else if (element.webkitRequestFullscreen) { // Chrome, Safari and Opera
      element.webkitRequestFullscreen();
  } else if (element.msRequestFullscreen) { // IE/Edge
      element.msRequestFullscreen();
  }
}
