<template>
  <div class="content">
    <section class="content-header h-container-between-center">
      
        
         
            <h1>Danh sách sinh viên</h1>
         
          
            <button
              type="button"
              class="h-btn"
              id="btnAdd"
              data-toggle="modal"
              data-target="#createNV"
            >
              <i class="h-icon h-icon-add"></i> &nbsp; Thêm mới
            </button>
         
       
      
      <!-- /.container-fluid -->
    </section>
    <!-- /.Header content -->
    <section class="content-main">
      <div class="container-fluid">
        <!-- control content -->
        <div class="row">
          <div class="col-md-3">
            <div class="form-group">
              <input
                type="search"
                class="form-control input-search icon-search"
                placeholder="Tìm kiếm theo mã nhân viên, họ tên..."
                aria-controls="example1"
                name="searching"
              />
            </div>
          </div>
          <div class="col-md-2">
            <!-- select -->
            <div class="form-group">
              <select class="form-control" name="PhongBan" id="PhongBan">
                <option value="0" selected>-Tất cả phòng ban--</option>
                <option value="1">Phòng Đào tạo</option>
                <option value="2">Phòng Công nghệ</option>
                <option value="3">Phòng Narketing</option>
                <option value="4">Phòng Nhân sự</option>
              </select>
            </div>
          </div>
          <div class="col-md-2">
            <!-- select -->
            <div class="form-group">
              <select class="form-control" name="ViTri" id="ViTri">
                <option value="0" selected>--Tất cả vị trí--</option>
                <option value="1">Giám đốc</option>
                <option value="2">Thu ngân</option>
                <option value="3">Nhân viên Marketing</option>
              </select>
            </div>
          </div>
          <div class="col-md-2"></div>

          <div class="col-md-3 container-end">
            <button
              id="btnSearch"
              class="m-second-button m-btn-search"
            ></button>
            <button id="btnUpdate" class="m-second-button m-btn-update">
              Sửa
            </button>
            <button id="btnDelete" class="m-second-button m-btn-delete">
              Xóa
            </button>
            <button
              id="btnRefresh"
              class="m-second-button m-btn-refresh"
            ></button>
          </div>

          <!-- /.control content -->
        </div>
        <div class="row">
          <div class="grid grid-customer">
            <div
              class="el-table__body-wrapper is-scrolling-none el-table__body_custom"
            >
              <table
                id="tbListData"
                cellspacing="0"
                cellpadding="0"
                border="0"
                class="el-table__body"
                style="min-width: 100%"
              >
                <thead class="has-gutter">
                  <tr class="el-table__row">
                    <th colspan="1" rowspan="1" fieldName="EmployeeCode">
                      <div class="cell" style="width: 130px">Mã nhân viên</div>
                    </th>
                    <th colspan="1" rowspan="1" fieldName="FullName">
                      <div class="cell">Họ và tên</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="Gender"
                      formatType="Gender"
                    >
                      <div class="cell w-82">Giới tính</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="DateOfBirth"
                      formatType="ddmmyyyy"
                      style="text-align: center"
                    >
                      <div class="cell">Ngày sinh</div>
                    </th>
                    <th colspan="1" rowspan="1" fieldName="PhoneNumber">
                      <div class="cell">Số điện thoại</div>
                    </th>
                    <th colspan="1" rowspan="1" fieldName="Email">
                      <div class="cell">Email</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="PositionId"
                      formatType="PositionName"
                    >
                      <div class="cell">Chức vụ</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="DepartmentId"
                      formatType="DepartmentName"
                    >
                      <div class="cell">Phòng ban</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="Salary"
                      formatType="Money"
                    >
                      <div class="cell w-140">Mức lương cơ bản</div>
                    </th>
                    <th
                      colspan="1"
                      rowspan="1"
                      fieldName="WorkStatus"
                      formatType="WorkStatusName"
                    >
                      <div class="cell w-155">Tình trạng công việc</div>
                    </th>
                    <th class="gutter" style="width: 6px"></th>
                  </tr>
                </thead>
                <tbody>
                  <tr class="el-table__row first">
                    <td rowspan="1" colspan="1" style="width: 100px">
                      <div class="cell">NV-0441943</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 143px">
                      <div class="cell">Nguyễn Huy Long</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 58px">
                      <div class="cell">Nam</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 100px">
                      <div class="cell text-align-center">12/02/2000</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 119px">
                      <div class="cell">0945449964</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 192px">
                      <div class="cell">longlouis1222@gmail.com</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 72px">
                      <div class="cell">Fresher</div>
                    </td>
                    <td
                      rowspan="1"
                      colspan="1"
                      class="text-align-right"
                      style="width: 55px"
                    >
                      <div class="cell">Công nghệ</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 232px">
                      <div class="cell text-align-right">9000000</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 98px">
                      <div class="cell">Đang thử việc</div>
                    </td>
                    <td rowspan="1" colspan="1" style="width: 32px">
                      <div class="cell"></div>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
          <!-- processing load -->
          <div class="d-flex justify-content-center">
            <div class="processing-example text-info" role="status"></div>
            <span class="sr-only">Loading...</span>
          </div>
        </div>
      </div>
    </section>
    <section class="content-footer">
      <div class="container-fluid">
        <!-- control content -->
        <div class="row">
          <div class="paging-bar">
            <div class="paging-record-info">
              Hiển thị <b>1-10/1000</b> Khách hàng
            </div>
            <div class="paging-option">
              <div class="btn-select-page m-btn-firstpage"></div>
              <div class="btn-select-page m-btn-prev-page"></div>
              <div class="m-btn-list-page">
                <button class="btn-pagenumber btn-pagenumber-selected">
                  1
                </button>
                <button class="btn-pagenumber">2</button>
                <button class="btn-pagenumber">3</button>
                <button class="btn-pagenumber">4</button>
              </div>
              <div class="btn-select-page m-btn-next-page"></div>
              <div class="btn-select-page m-btn-lastpage"></div>
            </div>
            <div class="paging-record-option"><b>10</b> Khách hàng/trang</div>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  name: 'Content',
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.content {
    position: relative;    
    margin-left: 201px;   
    width: calc(100%-201px);
    background-color: azure;
    
    padding:2px;
    
}
.content-main {
    margin-left: 10px;
    margin-right: 10px;
}

.content-header {
 margin: 0.5rem 1rem 0.5rem 1rem;
}


.content-footer {
    margin-left: 10px;
    margin-right: 10px;
}
</style>
