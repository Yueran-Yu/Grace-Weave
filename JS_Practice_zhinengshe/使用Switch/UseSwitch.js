window.onload = function () {
    var name = 'abc';
    var sex='male';

    switch (sex)
    {
        case 'male':
            alert('Mr. ' + name + ' hello!');
            break;
        case 'female':
            alert('Miss ' + name + ' hello!');
        default:
            alert(name + ' hello');
    }
}