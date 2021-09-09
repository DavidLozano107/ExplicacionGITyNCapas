using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace EjemploTelegram.api.Controllers
{
    [Route("api/bot")]
    [ApiController]
    public class BotController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            TelegramBotClient client = new TelegramBotClient("1905275607:AAES5SesY5EwmTs5J9MvgRDiZzRNOsiY-R4");
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {

                var id = update.Message.From.Id;
                var mensaje = "Reunion a las 8";

                if (update.Message.Text.ToLower().Contains("foto"))
                {
                   await client.SendPhotoAsync(
                  chatId: id,
                  photo: "https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
                  caption: "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>"
                );
                }
                else if (update.Message.Text.ToLower().Contains("luvia"))
                {
                    await client.SendPhotoAsync(
                   chatId: id,
                   photo: "https://cdn.pixabay.com/photo/2014/09/21/14/39/surface-455124_960_720.jpg",
                   caption: "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>"
                 );
                }
                else if (update.Message.Text.ToLower().Contains("video"))
                {
                    await client.SendVideoAsync(
                      chatId: id,
                      video: "https://raw.githubusercontent.com/TelegramBots/book/master/src/docs/video-countdown.mp4",
                      thumb: "https://raw.githubusercontent.com/TelegramBots/book/master/src/2/docs/thumb-clock.jpg",
                      supportsStreaming: true
                    );
                }
                else
                {
                    await client.SendTextMessageAsync(
                      chatId: id,
                      text: mensaje
                    );
                }
            }
            return Ok();
        }
    }
}
