<template>
  <div class="filter-bar">
    <div class="filter-left">
      <input
        id="txtSearchEmployee"
        class="icon-search input-search"
        type="text"
        placeholder="Tìm kiếm theo Mã, Tên hoặc Số điện thoại"
      />
      <select
        id="cbxDepartment"
        fieldName="CustomerGroupName"
        fieldValue="CustomerGroupId"
        api="/api/customergroups"
        class="m-control"
      >
        <option value="19165ed7-212e-21c4-0428-030d4265475f">
          Tất cả phòng ban
        </option>
        <option value="19165ed7-212e-21c4-0428-030d4265475f">
          Văn phòng Tổng công ty
        </option>
        <option value="7a0b757e-41eb-4df6-c6f8-494a84b910f4">
          Phong đào tạo công nghệ
        </option>
        <option value="3631011e-4559-4ad8-b0ad-cb989f2177da">
          Phòng Nhân sự
        </option>
      </select>
      <select
        id="cbxPosition"
        fieldName="CustomerGroupName"
        fieldValue="CustomerGroupId"
        api="/api/customergroups"
        class="m-control"
      >
        <option value="19165ed7-212e-21c4-0428-030d4265475f">
          Tất cả vị trí
        </option>
        <option value="19165ed7-212e-21c4-0428-030d4265475f">Giám đốc</option>
        <option value="7a0b757e-41eb-4df6-c6f8-494a84b910f4">
          Trưởng phòng
        </option>
        <option value="3631011e-4559-4ad8-b0ad-cb989f2177da">Nhân viên</option>
      </select>
    </div>
    <div class="filter-right">
      <button id="btnRefresh" class="m-second-button m-btn-refresh"></button>
    </div>
  </div>
  <div
    class="grid grid-employee el-table el-table--fit el-table--scrollable-y el-table--enable-row-hover el-table--enable-row-transition"
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
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_114 is-leaf"
            fieldName="EmployeeCode"
          >
            <div class="cell">Mã nhân viên</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_115 is-leaf"
            fieldName="FullName"
          >
            <div class="cell">Họ và tên</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="GenderName"
          >
            <div class="cell">Giới tính</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="DateOfBirth"
            formatType="ddmmyyyy"
            style="text-align: center"
          >
            <div class="cell">Ngày sinh</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="PhoneNumber"
          >
            <div class="cell">Điện thoại</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="Email"
          >
            <div class="cell">Email</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="PositionName"
          >
            <div class="cell">Chức vụ</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="DepartmentName"
          >
            <div class="cell">Phòng ban</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="Salary"
            formatType="Money"
          >
            <div class="cell" style="text-align: right">Mức lương cơ bản</div>
          </th>
          <th
            colspan="1"
            rowspan="1"
            class="el-table_30_column_116 is-leaf"
            fieldName="WorkStatusName"
          >
            <div class="cell">Tình trạng công việc</div>
          </th>
          <th class="gutter" style="width: 6px"></th>
        </tr>
      </thead>
      <tbody>
        <tr
          class="el-table__row"
          v-for="emp in employees"
          :key="emp.Id"
          @click="selectedEmployee = emp"
        >
          <td rowspan="1" colspan="1" class="el-table_1_column_1">
            <div class="cell">2016-05-03</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_2">
            <div class="cell">{{ emp.FullName }}</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">Nam</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">22/09/1989</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">0977340334</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">manhnv229@gmail.com</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">Nhân viên</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">Phòng đào tạo</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">10.000.000</div>
          </td>
          <td rowspan="1" colspan="1" class="el-table_1_column_3">
            <div class="cell">Đang làm việc</div>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
  <div class="paging-bar">
    <div class="paging-record-info">Hiển thị <b>1-10/1000</b> nhân viên</div>
    <div class="paging-option">
      <div class="btn-select-page m-btn-firstpage"></div>
      <div class="btn-select-page m-btn-prev-page"></div>
      <div class="m-btn-list-page">
        <button class="btn-pagenumber btn-pagenumber-selected">1</button>
        <button class="btn-pagenumber">2</button>
        <button class="btn-pagenumber">3</button>
        <button class="btn-pagenumber">4</button>
      </div>
      <div class="btn-select-page m-btn-next-page"></div>
      <div class="btn-select-page m-btn-lastpage"></div>
    </div>
    <div class="paging-record-option"><b>10</b> nhân viên/trang</div>
  </div>
</template>

<style scoped>
.grid-employee {
  margin-top: 10px;
  height: calc(100vh - 234px);
}

.el-avatar-employee {
  padding-top: 16px;
  padding-right: 16px;
}

.el-left {
  width: calc(100% - 180px);
}

.el-avatar-employee .el-avatar {
  border: 1px solid #ccc;
  width: 160px;
  height: 160px;
  margin: 0 auto;
  border-radius: 50%;
  cursor: pointer;
  /* background-image: url("/assets/img/default-avatar.jpg"); */
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
}

.el-avatar-note {
  font-size: 12px;
}
.filter-left {
  display: flex;
}
.filter-left select {
  margin-left: 10px;
  margin-right: 10px;
}

.currency-for-input {
  position: absolute;
  right: 40px;
  line-height: 40px;
  font-style: italic;
}

#txtSearchEmployee {
  min-width: 300px;
}
</style>

<script>
import * as axios from "axios";

export default {
  name: "Employees",
  data() {
    return {
      selectedEmployee: {
        EmployeeId: 1,
        FullName: "Nguyễn Văn Mạnh",
      },
      employees: [
        {
          EmployeeId: 1,
          FullName: "Nguyễn Văn Mạnh",
        },
        {
          EmployeeId: 1,
          FullName: "Nguyễn Văn Mạnh",
        },
        {
          EmployeeId: 1,
          FullName: "Nguyễn Văn Mạnh",
        },
      ],
    };
  },
  async created() {
    const response = await axios.get("http://api.manhnv.net/api/employees");
    this.employees = response;
  },
};
</script>