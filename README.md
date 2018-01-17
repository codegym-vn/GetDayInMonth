# GetDayInMonth

Mục tiêu

Luyện tập sử dụng câu lệnh điều kiện switch-case.

Mô tả

Trong phần này, chúng ta sẽ phát triển một ứng dụng để tính số ngày của một tháng. Ứng dụng cho phép người dùng nhập vào một tháng và hiển thị số ngày có trong tháng đó. Ví dụ, nếu người dùng nhập vào tháng 8 thì sẽ hiển thị “Tháng 8 có 31 ngày”, nếu người dùng nhập vào tháng 9 thì sẽ hiển thị “Tháng 9 có 30 ngày”.

Hướng dẫn

Đầu tiên chúng ta xác định yêu cầu bài toán:

Ứng dụng cho phép nhập vào 1 tháng và hiển thị số ngày của tháng đó.
Phân tích:

Trong 1 năm các tháng có 30 ngày là 4, 6, 9, 11 còn các tháng có 31 ngày là 1, 3, 5, 7, 8, 12
Riêng tháng 2 có từ 28, 29 ngày tùy theo có phải là năm nhuận không.
Từ phân tích trên muốn biết được tháng 2 có 28 hay 29 ngày ta cần biết đó là năm nào, có phải năm nhuận không.
Cách giải:

Viết code tính toán xem năm nhập vào có phải năm nhuận không. Nếu là năm nhuận thì tháng 2 có 29 ngày, nếu không phải năm nhuận thì tháng 2 có 28 ngày.
Viết code kiểm tra tháng nhập vào là tháng mấy để tính ra số ngày.
Viết code đọc dữ liệu từ bàn phím.
Chi tiết:

Viết code đọc dữ liệu năm, tháng từ bàn phím
Kiểm tra nếu tháng, năm nhập vào là hợp lệ và 1 <= tháng <= 12 nếu:
Hợp lệ: Sử dụng câu lệnh switch để kiểm tra tháng nhập vào. Tương ứng các giá trị 4, 6, 9, 11 là tháng có 30 ngày, các giá trị 1, 3, 5, 7, 8, 12 là các tháng có 31 ngày. Nếu giá trị nhập vào là 2 thì xét tiếp xem năm nhập vào có phải là năm nhuận không. Không hợp lệ: Thông báo
Lưu ý: Năm nhuận là năm chia hết cho 400 hoặc chia hết cho 4 và không chia hết cho 100