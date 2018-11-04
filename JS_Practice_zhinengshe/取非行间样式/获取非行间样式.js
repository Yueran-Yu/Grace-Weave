function getStyle(obj,name)
{
    if(obj.currentStyle)
    {
        return obj.currentStyle[name];
    }
    else
    {
        return getComputedStyle(obj,null)[name];
    }
}

window.onload = function () {
    var oDiv = document.getElementById('div1');
    //IE
    //alert(oDiv.currentStyle.width);
    //Chrome, FF
    //alert(getComputedStyle(oDiv,null).width);

   alert(getStyle(oDiv,'width'));
    alert(getStyle(oDiv,'backgroundColor'));

}