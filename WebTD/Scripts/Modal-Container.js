// Modal表示を可能にするScriptです

$(function () {
    $('body').on('click', '.modal-link', function (e) {
        e.preventDefault();
        $(this).attr('data-target', '#modal-container');
        $(this).attr('data-toggle', 'modal');
    });

    // .modal-close-btnのリスナーを作成
    $('body').on('click', '.modal-close-btn', function () {
        $('#modal-container').modal('hide');
    });

    // 閉じた瞬間にキャッシュを消去する
    $('#modal-container').on('hidden.bs.modal', function () {
        $(this).removeData('bs.modal');
    });
    $('#CancelModal').on('click', function () {
        return false;
    });
});