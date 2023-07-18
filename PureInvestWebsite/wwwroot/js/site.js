document.addEventListener("DOMContentLoaded", function () {
    var buyNowButton = document.getElementById("buyNowButton");
    if (buyNowButton) {
        buyNowButton.addEventListener("click", function (event) {
            event.preventDefault(); // Prevent the form from submitting

            // Perform the desired action here
            // Example: Display a message or make an API request

            // Replace the following line with your desired logic
            alert("Purchase successful!");
        });
    }
});
