<template>
  <div class="content">
    <div class="header-content">
      <div class="title">Danh sách nhân viên</div>
      <div class="content-feature">
        <button id="btnAdd" class="m-btn m-btn-default" v-on:click="btnAddOnClick" >
          <div class="m-btn-icon icon-add"></div>
          <div class="btn-text">Thêm nhân viên</div>
        </button>
      </div>
    </div>
    <router-view/>
  </div>
</template>
<script>
export default {
  methods: {
    btnAddOnClick () {
      alert (1);
    }
  },
}
</script>