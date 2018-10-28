window.onload = function () {

// 解决两个问题：
    // ①如何选中这些复选框
    // ②如何控制一个js 到底是选中还是不选中
    var oBtn1 = document.getElementById('btn1');
    var oDiv = document.getElementById('div1');
    var aCh = oDiv.getElementsByTagName('input');
    oBtn1.onclick = function ()
    {
        //aCh[0].checked = true;
        for(var i = 0; i < aCh.length; i++)
        {
            aCh[i].checked = true;
        }
    };

    var oBtn2 = document.getElementById('btn2');
    oBtn2.onclick = function ()
    {
        //aCh[0].checked = true;
        for(var i = 0; i < aCh.length; i++)
        {
            aCh[i].checked = false;
        }
    };

    var oBtn3 = document.getElementById('btn3');
    oBtn3.onclick = function ()
    {
        //aCh[0].checked = true;
        for(var i = 0; i < aCh.length; i++)
        {
            if(aCh[i].checked == true){
                aCh[i].checked = false;
            }else{
                aCh[i].checked= true;
            }

        }
    };
}