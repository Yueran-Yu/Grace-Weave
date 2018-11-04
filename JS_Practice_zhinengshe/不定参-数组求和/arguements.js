function sum(){
    var result = 0;

    for(var i=0; i <arguments.length; i++)
    {
        result += arguments[i];
    }
    return result;
}

    alert(sum(23,4,3,1,2,34));
