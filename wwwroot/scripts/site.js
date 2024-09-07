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

  if (!document.fullscreenElement) {
    // Enter fullscreen mode
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
    }
  } else {
    // Exit fullscreen mode
    if (document.exitFullscreen) {
      document.exitFullscreen();
    } else if (document.webkitExitFullscreen) { // Safari
      document.webkitExitFullscreen();
    } else if (document.mozCancelFullScreen) { // Firefox
      document.mozCancelFullScreen();
    } else if (document.msExitFullscreen) { // IE/Edge
      document.msExitFullscreen();
    }
  }
}

window.toggleAudioMute = (isMuted) => {
  let audioElements = document.querySelectorAll("audio");
  console.log("Audio elements found:", audioElements.length); // Check how many audio elements are selected
  audioElements.forEach(audio => {
      audio.muted = isMuted;
      console.log(audio.id, " is now ", isMuted ? "muted" : "unmuted"); // Debug each audio element
  });
};






