// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const uuid = 'qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnm'; // Сгенерируйте случайную строку — рекомендуем использовать представление не менее 36 символов. Далее эта строка используется для проверки, что запрос идет именно со стороны вашего приложения.
const appId = 51878346; // Идентификатор вашего приложения.
const redirectUri = 'localhost'; // Адрес для перехода после авторизации, который совпадает с доверенным редиректом из настроек приложения.
const redirect_state = '12345'; // Cостояние вашего приложения или любая произвольная строка, которая будет добавлена к url после авторизации.

const query = `uuid=${uuid}&app_id=${appId}&response_type=silent_token&redirect_uri=${redirectUri}&redirect_state=${redirect_state}`;

// Получаем кнопку по ее иденификатору
var myButton = document.getElementById('VKIDSDKAuthButton');

// Добавляем обработчик события на нажатие кнопки
myButton.addEventListener('click', function () {
    location.assign(`https://id.vk.com/auth?${query}`);
});