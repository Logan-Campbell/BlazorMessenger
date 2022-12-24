var LANMessenger = LANMessenger || {};
LANMessenger.scrollBottom = function (id) {
    var element = document.getElementById(id);
    element.scroll = element.scrollHeight;
};