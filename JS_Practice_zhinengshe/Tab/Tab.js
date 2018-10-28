window.onload = function () {
  var oDiv=document.getElementById('div1');
  var aBtn = oDiv.getElementsByTagName('input');
  var aDiv = oDiv.getElementsByTagName('div');

  for(var i=0; i<aBtn.length; i++){

      aBtn[i].index = i;
      aBtn[i].onclick = function () {
        //alert(this.value); 为了测试this.value的功能，指代当前按钮

            //该index 不是通过HTML加进去的，
            //而是通过JavaScript 加到 input 里面的
            //这样 每一个 input里面就有一个 index 的属性
            //通过HTML加入的属性 浏览器是不认的。通过JavaScript 浏览器可行
          for(var i=0;i<aBtn.length; i++)
          {
            aBtn[i].className = '';
            aDiv[i].style.display='none';
          }
          this.className = 'active';
          aDiv[this.index].style.display = 'block';
      };
  }
}
//this :  当前发生事件的元素