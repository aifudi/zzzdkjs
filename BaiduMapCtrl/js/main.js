// 在此放置代码!
// 百度地图API功能
// 支持代码编辑的智能提示
///<reference path="mapPromptDoc.js">
var map = new BMap.Map("allmap");    // 创建Map实例
map.centerAndZoom(new BMap.Point(113.16, 27.83), 11);  // 初始化地图,设置中心点坐标和地图级别
//添加地图类型控件
map.addControl(new BMap.MapTypeControl({
    mapTypes: [
        BMAP_NORMAL_MAP,
        BMAP_HYBRID_MAP
    ]
}));
map.setCurrentCity("株洲");          // 设置地图显示的城市 此项是必须设置的
map.enableScrollWheelZoom(true);     //开启鼠标滚轮缩放
map.addControl(new BMap.NavigationControl());   // 添加平移缩放控件
map.addControl(new BMap.ScaleControl());        // 添加比例尺控件
map.addControl(new BMap.OverviewMapControl());  //添加缩略地图控件
map.addControl(new BMap.MapTypeControl());      //添加地图类型控件
map.addEventListener("click", localsearch);

function localsearch(city) {
    var local = new BMap.LocalSearch(map, {
        renderOptions: { map: map, panel: "r-result" }  //构造本地搜索对象  
    });
    local.search(city);
}

// 定义一个控件类,即function
function ZoomControl() {
    // 默认停靠位置和偏移量
    this.defaultAnchor = BMAP_ANCHOR_TOP_LEFT;
    this.defaultOffset = new BMap.Size(200, 0);
}

// 通过JavaScript的prototype属性继承于BMap.Control
ZoomControl.prototype = new BMap.Control();

// 自定义控件必须实现自己的initialize方法,并且将控件的DOM元素返回
// 在本方法中创建个div元素作为控件的容器,并将其添加到地图容器中
ZoomControl.prototype.initialize = function (map) {
    // 创建一个DOM元素
    var div = document.createElement("div");
    // 添加文字说明
    div.appendChild(document.createTextNode("放大2级"));
    // 设置样式
    div.style.cursor = "pointer";
    div.style.border = "1px solid gray";
    div.style.backgroundColor = "white";

    // 绑定事件,点击一次放大两级
    div.onclick = function (e) {
        map.setZoom(map.getZoom() + 2);
    }
    // 添加DOM元素到地图中
    map.getContainer().appendChild(div);
    // 将DOM元素返回
    return div;
}
// 创建控件
var myZoomCtrl = new ZoomControl();
// 添加到地图当中
map.addControl(myZoomCtrl);


function test() {

    var point = new BMap.Point(113.16, 27.83);
    var marker = new BMap.Marker(point); // 创建标注
    map.addOverlay(marker); // 将标注添加到地图中
    map.centerAndZoom(point, 15);
    var opts = {
        width: 200, // 信息窗口宽度
        height: 100, // 信息窗口高度
        title: "海底捞王府井店", // 信息窗口标题
        enableMessage: true, //设置允许信息窗发送短息
        message: "亲耐滴，晚上一起吃个饭吧？戳下面的链接看下地址喔~"
    }
    var infoWindow = new BMap.InfoWindow("地址：北京市东城区王府井大街88号乐天银泰百货八层", opts); // 创建信息窗口对象 
    map.openInfoWindow(infoWindow, point); //开启信息窗口

    //marker.addEventListener("click",
    //    function() {
    //        map.openInfoWindow(infoWindow, point); //开启信息窗口
    //    });

}

function AddPoint(lng, lat) {
    var marker = new BMap.Marker(new BMap.Point(lng, lat));  // 创建标注  
    map.addOverlay(marker);
    var opts = {
        width: 200, // 信息窗口宽度
        height: 100, // 信息窗口高度
        title: "部署位置信息", // 信息窗口标题
        enableMessage: true, //设置允许信息窗发送短息
        message: "运营商：电信~"
    }
    var infoWindow = new BMap.InfoWindow("地址：市政大厦", opts); // 创建信息窗口对象 
    map.openInfoWindow(infoWindow, new BMap.Point(lng, lat)); //开启信息窗口
    marker.addEventListener("click",
        function() {
            map.openInfoWindow(infoWindow, new BMap.Point(lng, lat)); //开启信息窗口
        });
}

/// 聚焦到当前位置
function MapOpOfFoucusPoint(lng, lat) {

    map.centerAndZoom(new BMap.Point(lng, lat), 16);
}


