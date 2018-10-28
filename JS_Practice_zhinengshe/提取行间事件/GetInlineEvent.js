
window.onload = function () {

    var oBtn = document.getElementById('btn1');

//为了 减少取名字的麻烦， 我们就使用 匿名函数
    /*function abc() {
        alert('a');
    }*/

    oBtn.onclick = function () {
        alert('a');
    };
//onclick也是按钮的一个属性，所以也能用js修改
//onclick 需要接受函数方法 abc
}