// var http = require('http');
// var url = require('url');
var express = require('express');
var app = express();
var path = require('path');

const PORT = 1300; // localhost:1300 -> https://viduata.serveo.net
const TOKEN = 'test_token_01';

app.listen(PORT, () => console.log(`Example app listening on port ${PORT}!`));

// respond with "hello world" when a GET request is made to the homepage
app.get('/', function (req, res) {
    console.log(path.join(__dirname + '/../public/index.html'));
    res.sendFile(path.join(__dirname + '/../public/index.html'));
})

// Thông báo sự kiện được tổng hợp và gửi hàng loạt với tối đa 1000 cập nhật. 
// Tuy nhiên, chúng tôi không thể đảm bảo cho hành động gửi hàng loạt, nên bạn hãy nhớ điều chỉnh để máy chủ xử lý từng Webhook riêng lẻ.
//
// Nếu không gửi được bất kỳ cập nhật nào đến máy chủ, chúng tôi sẽ thử lại ngay, sau đó thử lại thêm vài lần nữa với tần suất giảm dần trong 24 giờ tiếp theo. 
// Máy chủ của bạn sẽ xử lý việc bỏ trùng lặp trong những trường hợp này. Các phản hồi chưa xác nhận sẽ bị bỏ qua sau 24 giờ.

//create a server object:
// http.createServer(function (request, response) {

//     var queryData = url.parse(request.url, true).query;
//     console.log(request.url);
    
//     if (request.url == '/') {

//     }
//     else if (request.url.includes('favicon.ico')) {
//         response.end();
//         return;
//     }
    
//     if ( queryData['hub.mode'] == 'subscribe' 
//       && queryData['hub.verify_token'] == TOKEN
//     ) {
//         response.write(queryData['hub.challenge']);
//     } else {
//         // console.log(queryData['hub.verify_token']);
//         // res.writeHead(400, {'Content-Type': 'text/html'});
//         let body = [];
//         request.on('data', (chunk) => {
//             body.push(chunk);
//         }).on('end', () => {
//             body = Buffer.concat(body).toString();
//             console.log(body); //{"entry": [{"time": 1550052941, "id": "0", "changed_fields": ["message_sends"], "uid": "0"}], "object": "user"}
//         });
//         response.writeHead(200, {'Content-Type': 'text/html'}); //Điểm cuối của bạn phải phản hồi mọi Thông báo sự kiện bằng 200 OK HTTPS.
//         response.write('OK');
//     }
//     response.end(); //end the response

// }).listen(PORT); //the server object listens on port 8080

// Chúng tôi ký mọi phần tải dữ liệu Thông báo sự kiện bằng chữ ký SHA1 và thêm chữ ký này vào tiêu đề X-Hub-Signature của yêu cầu, đứng trước là sha1=. Mặc dù bạn không phải xác thực phần tải dữ liệu, nhưng bạn nên làm vậy.
// Cách xác thực phần tải dữ liệu:
//      Tạo chữ ký SHA1 bằng phần tải dữ liệu và Khóa bí mật của ứng dụng.
//      So sánh chữ ký của bạn với chữ ký trong tiêu đề X-Hub-Signature (mọi thứ sau sha1=). Nếu chữ ký khớp thì phần tải dữ liệu là thật.
