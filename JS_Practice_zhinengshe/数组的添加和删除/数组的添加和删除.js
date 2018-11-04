var arr=[4,2,6,35,3];

arr.sort(function (n1,n2) {
    return n1-n2;

//     if(n1<n2)
//     {
//         return -1;
//     }
//     else if(n1>n2)
//     {
//         return 1;
//     }
//     else
//     {
//         return 0;
//     }
});
alert("排序： "+arr);

arr.push(8);
arr.push(5);
arr.pop();
alert(arr);

arr.unshift(9);
arr.unshift(7);
arr.shift();
alert(arr);

arr.splice(2,3);
alert(arr);
arr.splice(2,0,'b','n','k');
alert(arr);
arr.splice(2,2,'e','s');
alert(arr);

var arr1 = [7,7,7];s
alert(arr.concat(arr1));

alert(arr.join('--*--*'));




