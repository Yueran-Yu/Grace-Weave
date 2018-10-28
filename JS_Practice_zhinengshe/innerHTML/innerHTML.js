window.onload = function () {
    //获取元素，准备事件
    var oTxt = document.getElementById('txt1');
    var oBtn = document.getElementById('btn1');
    var oDiv = document.getElementById('div1');

    oBtn.onclick = function () {
        oDiv.innerHTML = oTxt.value;
       alert(oDiv.innerHTML);
    };
}