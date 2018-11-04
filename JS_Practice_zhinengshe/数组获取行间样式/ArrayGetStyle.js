function css(obj,name,value)
{
    if(arguments.length == 2) //获取元素
    {
        return obj.style[name];
    }
    else   //设置样式
    {
        obj.style[name] = value;
    }
}

window.onload = function ()
{
    var oDiv = document.getElementById('div1');
   // alert(css(oDiv,'width'));
    css(oDiv,'background','green')

}