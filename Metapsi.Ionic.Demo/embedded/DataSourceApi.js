export const GetRemoteDataSource = (args, nextAction) => {
    console.log(args);
    console.log(nextAction);
    return fetch(
        '/query?q=' + args
    )
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {
            //var newDataSource = data.map(function (v) {
            //    return { value: v, label: v };
            //});
            nextAction(data);
        });
}