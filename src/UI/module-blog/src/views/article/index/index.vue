<template>
  <nm-container>
    <nm-list ref="list" v-bind="list">
      <!--查询条件-->
      <template v-slot:querybar>
        <el-form-item label="标题：" prop="title">
          <el-input v-model="list.model.title" clearable/>
        </el-form-item>
        <el-form-item label="所属分类：" prop="categoryId">
          <el-input v-model="list.model.categoryId" clearable/>
        </el-form-item>
        <el-form-item label="多媒体类型：" prop="mediaType">
          <el-input v-model="list.model.mediaType" clearable/>
        </el-form-item>
        <el-form-item label="简介：" prop="summary">
          <el-input v-model="list.model.summary" clearable/>
        </el-form-item>
        <el-form-item label="内容：" prop="content">
          <el-input v-model="list.model.content" clearable/>
        </el-form-item>
        <el-form-item label="私有的：" prop="private">
          <el-input v-model="list.model.private" clearable/>
        </el-form-item>
        <el-form-item label="已发布的：" prop="published">
          <el-input v-model="list.model.published" clearable/>
        </el-form-item>
        <el-form-item label="发布日期：" prop="publishedTime">
          <el-input v-model="list.model.publishedTime" clearable/>
        </el-form-item>
        <el-form-item label="阅读数：" prop="readCount">
          <el-input v-model="list.model.readCount" clearable/>
        </el-form-item>
        <el-form-item label="赞数：" prop="likeCount">
          <el-input v-model="list.model.likeCount" clearable/>
        </el-form-item>
      </template>

      <!--按钮-->
      <template v-slot:querybar-buttons>
        <nm-button-has :options="buttons.add" @click="add" />
      </template>

      <!--自定义列-->
      <!-- <template v-slot:col-name="{row}">
        <nm-button :text="row.name" type="text" />
      </template> -->

      <!--操作列-->
      <template v-slot:col-operation="{row}">
        <nm-button v-bind="buttons.edit" @click="edit(row)" />
        <nm-button-delete v-bind="buttons.del" :id="row.id" :action="removeAction" @success="refresh"/>
      </template>
    </nm-list>

    <!--添加-->
    <add-page :visible.sync="dialog.add" @success="refresh"/>
    <!--编辑-->
    <edit-page :id="curr.id" :visible.sync="dialog.edit" @success="refresh"/>
  </nm-container>
</template>
<script>
import page from './page'
import cols from './cols'
import AddPage from '../components/add'
import EditPage from '../components/edit'

const api = $api.blog.article

export default {
  name: page.name,
  components: { AddPage, EditPage },
  data () {
    return {
      curr: { id: '' },
      list: {
        title: page.title,
        cols,
        action: api.query,
        model: {
          /** 标题 */
          title: '',
          /** 所属分类 */
          categoryId: '',
          /** 多媒体类型 */
          mediaType: '',
          /** 简介 */
          summary: '',
          /** 内容 */
          content: '',
          /** 私有的 */
          private: '',
          /** 已发布的 */
          published: '',
          /** 发布日期 */
          publishedTime: '',
          /** 阅读数 */
          readCount: '',
          /** 赞数 */
          likeCount: ''
        }
      },
      removeAction: api.remove,
      dialog: {
        add: false,
        edit: false
      },
      buttons: page.buttons
    }
  },
  methods: {
    refresh () {
      this.$refs.list.refresh()
    },
    add () {
      this.dialog.add = true
    },
    edit (row) {
      this.curr = row
      this.dialog.edit = true
    }
  }
}
</script>
