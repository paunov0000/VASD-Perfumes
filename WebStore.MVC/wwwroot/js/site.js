document.getElementById("arrow-down").onclick = function (e) {
  var text = document.getElementById(`product-quantity`);
  if (text.value === "") {
    text.value = 1;
  }
  var quantity = parseInt(text.value);
  if (quantity <= 1) {
    text.value = 1;
  } else {
    text.value = quantity - 1;
  }
};

document.getElementById("arrow-up").onclick = function (e) {
  var text = document.getElementById(`product-quantity`);
  if (text.value === "") {
    text.value = 1;
  }
  var quantity = parseInt(text.value);
  text.value = quantity + 1;
}

document.getElementById("product-quantity").oninput = function (e) {
  this.value = this.value.replace(/[^0-9]/g, '');
}
