# Giải thuật điều phối tiến trình CPU

## :one: SJF Non Preemptive
### Thuật toán: 
- Sắp xếp tất cả các quá trình theo thời gian đến. 
- Sau đó, chọn quy trình có thời gian đến tối thiểu và thời gian Burst tối thiểu. 
- Sau khi hoàn thành quy trình, hãy tạo một nhóm quy trình cho đến khi hoàn thành quy trình trước đó và chọn quy trình đó trong số nhóm có thời gian Burst tối thiểu.
### Làm thế nào để tính toán thời gian dưới đây trong SJF bằng cách sử dụng một chương trình? 
- Thời gian hoàn thành: Thời gian mà quá trình hoàn thành việc thực thi.
- Thời gian quay vòng: Thời gian chênh lệch giữa thời gian hoàn thành và thời gian đến. `Thời gian quay vòng = Thời gian hoàn thành - Thời gian đến`
- Thời gian chờ (WT): Thời gian chênh lệch giữa thời gian quay vòng và thời gian liên tục. `Thời gian chờ = Thời gian quay vòng - Thời gian liên tục`

## :two: SJF Preemptive
### Di chuyển cho đến khi tất cả quá trình hoàn tất
1. Tìm quá trình có thời gian còn lại tối thiểu tại mỗi vòng thời gian duy nhất.
- Giảm thời gian của nó đi 1.
- Kiểm tra xem thời gian còn lại của nó có trở thành 0 không 
- Tăng bộ đếm hoàn thành quá trình. `Thời gian hoàn thành của quy trình hiện tại = hiện_thời + 1`
- Tính toán thời gian chờ đợi cho mỗi lần hoàn thành quá trình. `wt [i] = Thời gian hoàn thành - Arrival_time-burst_time`
- Khoảng thời gian tăng dần từng khoảng thời gian.

2. Tìm thời gian quay vòng (thời gian chờ đợi + thời gian bùng nổ).
### Ưu điểm:
- Các quy trình ngắn được xử lý rất nhanh chóng.
- Hệ thống cũng yêu cầu rất ít chi phí vì nó chỉ đưa ra quyết định khi một quy trình hoàn thành hoặc một quy trình mới được thêm vào.
- Khi một tiến trình mới được thêm vào, thuật toán chỉ cần so sánh tiến trình đang thực thi với tiến trình mới, bỏ qua tất cả các tiến trình khác hiện đang chờ thực thi.
### Nhược điểm:
- Giống như công việc ngắn nhất đầu tiên, nó có khả năng gây chết đói quy trình.
- Các quy trình dài có thể bị dừng vô thời hạn nếu các quy trình ngắn được thêm vào liên tục.

## :three: JCFS Non Arrival Time
### Làm thế nào để tính toán thời gian dưới đây trong Round Robin bằng cách sử dụng một chương trình? 
- Thời gian hoàn thành: Thời gian mà quá trình hoàn thành việc thực thi.
- Thời gian quay vòng: Thời gian chênh lệch giữa thời gian hoàn thành và thời gian đến. `Thời gian quay vòng = Thời gian hoàn thành - Thời gian đến`
- Thời gian chờ (WT): Thời gian chênh lệch giữa thời gian quay vòng và thời gian liên tục. `Thời gian chờ = Thời gian quay vòng - Thời gian liên tục`

### Thực hiện: 
- Nhập các quá trình cùng với thời gian bùng nổ của chúng (bt).
- Tìm thời gian chờ (wt) cho tất cả các tiến trình.
- Là quá trình đầu tiên đến không cần phải chờ đợi thời gian chờ cho tiến trình 1 sẽ là 0 tức là `wt [0] = 0`
- Tìm thời gian chờ cho tất cả các quá trình khác, tức là cho quy trình tôi -> `wt [i] = bt [i-1] + wt [i-1]`
- Tìm `thời gian quay vòng = wait_time + burst_time` cho tất cả các quy trình.
- Tìm `thời gian chờ trung bình = total_waiting_time / no_of_processes`
- Tương tự, tìm `thời gian quay vòng trung bình = total_turn_around_time / no_of_processes`

## :four: JCFS Non Arrival Time
### Thực hiện: 
- Nhập các quy trình cùng với thời gian bùng nổ của chúng (bt) và thời gian đến (lúc)
- Tìm thời gian chờ cho tất cả các quy trình khác, tức là cho một quy trình nhất định tôi: `wt [i] = (bt [0] + bt [1] + ...... bt [i-1]) - tại [i]`
- Bây giờ tìm lại `thời gian = wait_time + burst_time` cho tất cả các quá trình
- `Thời gian chờ trung bình = total_waiting_time / no_of_processes`
- `Thời gian quay vòng trung bình = total_turn_around_time / no_of_processes`

## :five: Round Robin
### Làm thế nào để tính toán thời gian dưới đây trong Round Robin bằng cách sử dụng một chương trình?
- Thời gian hoàn thành: Thời gian mà quá trình hoàn thành việc thực thi.
- Thời gian quay vòng: Thời gian Chênh lệch giữa thời gian hoàn thành và thời gian đến. `Thời gian quay vòng = Thời gian hoàn thành - Thời gian đến`
- Thời gian chờ (WT): Thời gian Chênh lệch giữa thời gian quay vòng và thời gian liên tục. `Thời gian chờ = Thời gian quay vòng - Thời gian liên tục`

### Các bước để tìm thời gian chờ của tất cả các quy trình:
- Tạo một mảng rem_bt [] để theo dõi phần còn lại thời gian bùng nổ của các quy trình. Mảng này ban đầu là một bản sao của bt [] (mảng thời gian bùng nổ)
- Tạo một mảng khác wt [] để lưu trữ thời gian chờ của các quy trình. Khởi tạo mảng này bằng 0.
- Thời gian khởi tạo: `t = 0`
- Tiếp tục duyệt qua tất cả các quá trình trong khi tất cả các quá trình không được thực hiện. Làm theo quy trình của tôi nếu nó là chưa xong.
  - Nếu `rem_bt [i]> lượng tử (i) t = t + lượng tử (ii) bt_rem [i] - = quantum`
  - Khác `(i) t = t + bt_rem [i]; (ii) wt [i] = t - bt [i](ii) bt_rem [i] = 0`

## :six: Danh sách hình ảnh: 
### Trang chủ
<img src="answer\home.png" alt="Trang chủ"/>

### Thuật toán FCFS
<img src="answer\fcfs.png" alt="Thuật toán FCFS"/>

### Thuật toán SJF
<img src="answer\sjf.png" alt="Thuật toán SJF"/>

### Thuật toán RR
<img src="answer\rr.png" alt="Thuật toán RR"/>
