<template>
  <div class="h-dialog" v-show="visible">
    <div class="h-dialog-background"></div>
    <div class="h-dialog-content">
      <div class="h-dialog-header">
        <div class="h-dialog-header-title">Thông tin nhân viên</div>
        <div class="h-dialog-header-close">
          <button id="btnCancel" v-on:click="hide()"></button>
        </div>
      </div>
      <div class="h-dialog-content-body">
        <div class="col-xs-3 ml-2">
          <!-- <im src="../../content/img/default-avatar.jpg" class="default-avt img-circle"> -->

          <p>(Vui lòng chọn ảnh có địng dạng .jpg, .jpeg, .png, .gif)</p>
          <input type="file" id="avtUpdate" style="display: none" />
        </div>
        <div class="col-xs-9 ml-2 mr-2 h-container-column">
          <div>
            <div class="group-label-info">A. Thông tin chung</div>
            <hr class="hr-group-label" />
          </div>
          <div>
            <div class="col-xs-6 h-container-column pd-1">
              <div class="form-group">
                <p class="label-text">
                  Mã nhân viên(<span class="required">*</span>)
                </p>
                <input type="text" id="em-code" class="form-control" required />
              </div>
              <div class="form-group">
                <p class="label-text">Ngày sinh</p>
                <input
                  type="date"
                  id="em-birth"
                  class="form-control"
                  placeholder="mm/dd/yyyy"
                />
              </div>

              <div class="form-group">
                <p class="label-text">
                  Số CMTND/ Căn cước(<span class="required">*</span>)
                </p>
                <input
                  type="text"
                  id="em-identification"
                  class="form-control"
                  required
                />
              </div>
            </div>

            <div class="col-xs-6 h-container-column">
              <div class="form-group">
                <p class="label-text">
                  Họ và tên(<span class="required">*</span>)
                </p>
                <input type="text" id="em-name" class="form-control" required />
              </div>
              <div class="form-group">
                <p class="label-text">Giới tính</p>
                <select
                  id="em-gender"
                  dataIndex="Gender"
                  class="form-control"
                  fieldValue="value"
                  fieldText="text"
                  apiGetUrl="/api/v1/enums/gender"
                >
                  <option value="1">Nam</option>
                  <option value="0">Nữ</option>
                  <option value="2">Khác</option>
                </select>
              </div>

              <div class="form-group">
                <p class="label-text">
                  Số điện thoại(<span class="required">*</span>)
                </p>
                <input
                  type="text"
                  id="em-phone"
                  class="form-control"
                  required
                />
              </div>
            </div>
          </div>
          <div>
            <div class="col-xs-6 h-container-column pd-1">
              <div class="form-group">
                <p class="label-text">Nơi cấp</p>
                <input type="text" class="form-control" id="em-identifyPlace" />
              </div>
            </div>
          </div>
          <div>
            <div class="col-xs-6 h-container-column pd-1">
              <div class="form-group">
                <p class="label-text">Email(<span class="required">*</span>)</p>
                <input
                  type="email"
                  id="em-email"
                  class="form-control"
                  required
                />
              </div>
            </div>
            <div class="col-xs-6 h-container-column pd-1">
              <div class="form-group">
                <p class="label-text">
                  Số điện thoại(<span class="required">*</span>)
                </p>
                <input
                  type="text"
                  id="em-phone"
                  class="form-control"
                  required
                />
              </div>
            </div>
          </div>
          <div>
            <div class="group-label-info">B. Thông tin công việc</div>
            <hr class="hr-group-label" />
          </div>
          <div>
            <div class="col-xs-6 h-container-column pd-1">
              <div class="form-group">
                <p class="label-text">Vị trí</p>
                <select
                  id="em-position"
                  fieldName="PositionName"
                  fieldValue="PositionId"
                  class="form-control"
                  api="https://localhost:44376/api/EmployeePositions"
                >
                  <option value="19165ed7-212e-21c4-0428-030d4265475f">
                    Giám đốc
                  </option>
                  <option value="3631011e-4559-4ad8-b0ad-cb989f2177da">
                    Trưởng phòng
                  </option>
                  <option value="7a0b757e-41eb-4df6-c6f8-494a84b910f4">
                    Nhân viên
                  </option>
                </select>
              </div>
              <div class="form-group">
                <p class="label-text">Mã số thuế cá nhân</p>
                <input type="text" id="em-tax" class="form-control" />
              </div>
              <div class="form-group">
                <p class="label-text">Ngày gia nhập công ty</p>
                <input type="date" id="em-dateJoin" class="form-control" />
              </div>
            </div>
            <div class="col-xs-6 h-container-column">
              <div class="form-group">
                <p class="label-text">Phòng ban</p>
                <select
                  id="em-department"
                  fieldName="DepartmentName"
                  fieldValue="DepartmentId"
                  class="form-control"
                  api="https://localhost:44376/api/EmployeeDepartments"
                >
                  <option value="34bd2cef-5026-567c-3b71-153b37881afe">
                    Phòng đào tạo
                  </option>
                  <option value="43a6bdf5-1b6b-451b-3695-2c566fa88632">
                    Phòng công nghệ
                  </option>
                  <option value="64a59a25-2488-54b0-f6b4-c8af08a50cbf">
                    Phòng nhân sự
                  </option>
                  <option value="674934cc-42cf-20cf-1d4a-aea48a10ed18">
                    Phòng Marketting
                  </option>
                </select>
              </div>

              <div class="form-group pos-relative">
                <p class="label-text">Mức lương cơ bản</p>

                <input
                  type="text"
                  id="em-salary"
                  class="text-align-right pr-45 form-control"
                />
                <span class="currency-for-input">(VNĐ)</span>
              </div>
              <div class="form-group">
                <p class="label-text">Tình trạng công việc</p>
                <select id="cbxWorkStatus" class="form-control">
                  <option value="1">Đang làm việc</option>
                  <option value="2">Đang thử việc</option>
                  <option value="0">Đã nghỉ việc</option>
                </select>
              </div>
            </div>
          </div>
        </div>

        <!--<div class="dialog-btn">

                    </div>-->
      </div>
      <div class="h-dialog-footer h-container-end-center">
        <button
          class="h-btn h-cancel-btn"
          id="btnCancel"
          v-on:click="displayState = false"
        >
          Hủy
        </button>
        <button class="h-btn h-save-btn" id="btnSave">
          <i class="fa fa-floppy-o" aria-hidden="true"></i>Lưu
        </button>
      </div>
    </div>

    <!--<div class="warning">
                <div class="warning__content" title="Warning!!!">
                    <div class="warning-text">
                        <h2 style="color: red;">Cảnh báo !!!</h2>
                        <p style="font-size: 16px;padding: 16px;">Bạn có chắc muốn Xóa thông tin nhân viên này không ?</p>
                    </div>
                    <div class="warning-btn">
                        <button class="m-btn cancel-btn" id="btnCancel2">Hủy</button>
                        <button class="m-btn save-btn" id="btnOk">Có</button>
                    </div>
                </div>
            </div>-->
  </div>
</template>

<script>
export default {
  // props: {
  //     showModal: Boolean
  // }, pr
  data() {
    return {
      visible: false,
      para2: "hello world"
    };
  },
  watch: {
    // visible: function(newValu, oldValu) {
    //   console.log(' giá trị mới: ', newValu, ' giá trị cũ:', oldValu)
      
    // }
  },
  methods: {
    hide() {
     
      this.visible = false;
    },
    show() {       
      this.visible = true;
      return "ok";
    }
  },
};
</script>

<style src="../modal.scss" lang="scss" />
<style scoped>
.currency-for-input {
  position: absolute;
  right: 12px;
  top: 22px;
  line-height: 40px;
  font-style: italic;
}

.label-text {
  margin-bottom: 2px;
}

.default-avt {
  width: 170px;
  height: 165px;
  border: 1px solid #ccc;
  /* background-image: url('../../content/img/default-avatar.jpg'); */
  background-size: contain;
  margin: 0 auto;
  cursor: pointer;
}

.hr-group-label {
  width: 70px;
  margin-left: 0;
  margin-top: 7px;
  margin: 7px 0 7px 0;
  border: 2px solid #019160;
  background-color: #019160;
}
</style>