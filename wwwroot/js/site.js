// Write your JavaScript code.
let banners = [
    '❀˖°⋆Illuminate your space with our opulent candle collections',
    '❀˖°⋆Discover our luxurious glassware for refinement',
    '❀˖°⋆Limited Time Offer: Elevate Your Décor with Our Luxury Collection. Sale Now On!'
]; // Add your banner content here

let bannerIndex = 0;
let tickerContent = document.getElementById('bannerTicker');

function updateTickerContent() {
    tickerContent.textContent = banners[bannerIndex];
    bannerIndex = (bannerIndex + 1) % banners.length;
}

// Initial content setup
updateTickerContent();

function changeBanner() {
    updateTickerContent();
}

setInterval(changeBanner, 20000); 