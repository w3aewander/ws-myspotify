// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var isplaying = false;

const wsPlayMusic = (m, id) => {
  const player = $("#player");

  player.attr("src", m);

  console.log(player);

  const onplay = player.trigger("onplay");

  if (!isplaying) {
    player.trigger("load");
    player.trigger("play");

    $(`[data-id='icon-play-stop-${id}']`).html('<i class="fa fa-stop"></i>');

    $("#vumeter").html(
      '<img src="/img/vu-meter.gif" alt="" class="img-thumbnail">'
    );

    isplaying = true;
  } else {
    player.trigger("load");
    player.trigger("stop");

    $("#vumeter").html(
      '<img src="/img/vu-meter.png" alt=""  class="img-thumbnail" >'
    );
    $(`[data-id='icon-play-stop-${id}']`).html('<i class="fa fa-play"></i>');

    isplaying = false;
  }
};
