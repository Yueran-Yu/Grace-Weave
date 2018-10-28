window.onload = function () {
let aDiv = document.getElementsByTagName('div');
 //alert(aDiv.length);
 // aDiv.style.background='red';
 // 设置元素 只能一次设置一个
    for(var i = 0; i <aDiv.length; i++)
    aDiv[i].style.background = 'red';
}