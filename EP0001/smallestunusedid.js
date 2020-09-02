function nextId(ids) {

    let prev = 0;
    let next = 0;

    ids.sort(function (a, b) { return a - b });
    // console.log(ids);

    // for (let index = 0; index < ids.length; index++) {
    //     const element = ids[index];

    //     if (prev == 0) {
    //         prev = element;
    //     }

    //     if (prev == ids[index] + 1) {
    //         console.log(prev + 1);
    //         return prev + 1;
    //     }

    //     prev = ids[index];

    // }

    for (let index = ids.length - 1; index != 0; index--) {
        const element = ids[index];

        next = element + 1;

        console.log((ids[index] + 1));

        if ((ids[index] + 1) != next) {

            console.log(next);
            return next;
            
        }

        // if (prev == 0) {
        //     prev = element;
        // }

        // if (ids[index] + 1 != undefined)
        // {

        // }

        // if (prev == ids[index] + 1) {
        //     console.log(prev + 1);
        //     return prev + 1;
        // }

        // prev = ids[index];
    }

    //return 0;
}

nextId([0, 1, 2, 3, 5]);
nextId([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
nextId([0, 1, 2, 5, 4, 7, 8, 7, 8, 9, 10]);
nextId([12, 4, 3, 16, 1, 7, 8, 7, 8, 9, 10]);