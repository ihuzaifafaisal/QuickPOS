function updateClock() {
    var now = new Date();
    var hours = now.getHours();
    var minutes = now.getMinutes();
    var seconds = now.getSeconds();
    var ampm = hours >= 12 ? 'PM' : 'AM';
    hours = hours % 12;
    hours = hours ? hours : 12;
    minutes = minutes < 10 ? '0' + minutes : minutes;
    seconds = seconds < 10 ? '0' + seconds : seconds;

    var formattedTime = hours + ':' + minutes + ':' + seconds + ' ' + ampm;

    // Get formatted date
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var formattedDate = now.getDate() + ' ' + months[now.getMonth()] + ' ' + now.getFullYear();

    // Combine date and time
    var dateTimeString = formattedDate + ' ' + formattedTime;

    document.getElementById('clock').innerText = dateTimeString;
}

// Update the clock every second
setInterval(updateClock, 1000);

// Initial call to set the clock immediately
updateClock();