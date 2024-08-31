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
  