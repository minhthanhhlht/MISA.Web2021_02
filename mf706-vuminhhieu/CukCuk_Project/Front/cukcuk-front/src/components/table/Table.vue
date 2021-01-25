<template>
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
              <th colspan="1" rowspan="1" fieldName="Salary" formatType="Money">
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
    <div class="process-centure" v-show = visible>
      <div class="processing-example text-info" role="status"></div>
      <span class="sr-only">Loading...</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "Table",
  props:{
    msg:String
    
  },
  data(){
    return {
    visible: false
    }
  }  
};
</script>

<style src="./table.scss" lang="scss" />
<style scoped>
.process-centure{
  text-align: center;
}
</style>
