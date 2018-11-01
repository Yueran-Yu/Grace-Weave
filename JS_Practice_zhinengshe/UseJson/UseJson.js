window.onload = function () {
    var a = 12;
    var b = 5;
    var c = 'abc';
    //数组用的方括号，json用的是花括号
    var json = {a:12,b:5,c:'abc'};
    json.b++;
    //所有的 .   都可以用 '' 代替
    //alert(json.b);
    alert(json['b']);

    var arr =[12,5,7];
    alert(arr[0]);
    alert(arr.length);
    alert(json.length);

    for(var i in json)
    {
        alert('第' + i+ '个东西： ' + json[i]);
    }
}