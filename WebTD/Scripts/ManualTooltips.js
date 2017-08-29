
// 取扱説明書上における画像のツールチップを設定するJavascriptです
// Content部分は改行や太字を可能にするScriptです
// Positionはhtmlの位置によって変更します

$("#stageToolTip").tooltip({
    content: function () {
        return this.getAttribute("title");
    },
    position: {
        my: "top", at: "bottom", of: "#stagePic"
    }
});

$("#buttonToolTip").tooltip({
    content: function () {
        return this.getAttribute("title");
    },
    position: {
        my: "right", at: "left", of: "#buttonPic"
    }
});

$("#valueToolTip").tooltip({
    content: function () {
        return this.getAttribute("title");
    },
    position: {
        my: "right", at: "left", of: "#valuePic"
    }
});