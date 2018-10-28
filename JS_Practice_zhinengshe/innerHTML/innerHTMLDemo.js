
window.onload = function () {
    var arr=[
        '快过年了，大家可以商量着去哪里玩~',
        '快爱疯',
        '哥哥哥哥哥 ',
        '哈哈哈哈',
        '吼吼吼吼',
        '娃娃娃娃',
        'hihihihiHi好',
        '发电房',
        '是的问题呢',
        '消灭你与你何干！',
        '三体人',
        '逻辑'];
    var oDiv = document.getElementById('tab');
    var ali = oDiv.getElementsByTagName('li');
    var oTxt = oDiv.getElementsByTagName('div')[0];

    for(var i = 0; i<ali.length;i++)
    {
        ali[i].index = i;
        ali[i].onmouseover = function ()
        {
            for(var i = 0; i<ali.length; i++)
            {
                ali[i].className ='';
            }
            this.className = 'active';
            oTxt.innerHTML='<h2>'+(this.index + 1)+'月活动</h2><p>' + arr[this.index]+'</p>';
        };
    }
}